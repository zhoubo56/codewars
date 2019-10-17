using System.Collections.Generic;
using System.Linq;

namespace kyu3
{
    /// <summary>
    /// The Lift
    /// https://www.codewars.com/kata/the-lift
    /// </summary>
    public class TheLiftClass
    {
        public static int[] TheLift(int[][] queues, int capacity)
        {
            var stoppedFloors = new List<int>() { 0 };
            var lift = new Lift(capacity, queues.Length - 1);
            for (var i = 0; i < queues.Length; i++)
            {
                if (queues[i].Length <= 0) continue;
                foreach (var i1 in queues[i])
                {
                    lift.EntryWaitingQueues(new People(i, i1));
                }
            }
            lift.Run(ref stoppedFloors);
            return stoppedFloors.ToArray();
        }
    }

    /// <summary>
    /// 电梯
    /// </summary>
    public class Lift
    {
        /// <summary>
        /// 容量
        /// </summary>
        private readonly int _capacity;
        /// <summary>
        /// 楼层数
        /// </summary>
        private readonly int _floorNumber;
        /// <summary>
        /// 乘坐电梯的人
        /// </summary>
        private readonly List<People> _ridingPeoples = new List<People>();
        /// <summary>
        /// 等待电梯的人
        /// </summary>
        private readonly List<People> _waitingPeoples = new List<People>();

        public Lift(int capacity, int floorNumber)
        {
            _capacity = capacity;
            _floorNumber = floorNumber;
            Direction = 1;
            CurrentFloor = 0;
        }

        /// <summary>
        /// 方向
        /// 1:向上
        /// -1:向下
        /// </summary>
        public int Direction { get; private set; }

        /// <summary>
        /// 当前楼层
        /// </summary>
        public int CurrentFloor { get; private set; }

        private void ReverseDirection()
        {
            Direction *= -1;
        }

        private bool ExitArrivedPeople()
        {
            return _ridingPeoples.RemoveAll(p => p.WannaFloor == CurrentFloor) > 0;
        }

        private bool EntryOnePeople(People people)
        {
            if (_ridingPeoples.Count >= _capacity)
            {
                return false;
            }
            else
            {
                _ridingPeoples.Add(people);
                return true;
            }
        }

        private void GotoNextFloor()
        {
            CurrentFloor += Direction;
            if (CurrentFloor == _floorNumber || CurrentFloor == 0)
            {
                ReverseDirection();
            }
        }

        /// <summary>
        /// 进入等待队列
        /// </summary>
        /// <param name="people"></param>
        public void EntryWaitingQueues(People people)
        {
            _waitingPeoples.Add(people);
        }

        /// <summary>
        /// 运行
        /// </summary>
        /// <param name="stoppedFloors"></param>
        public void Run(ref List<int> stoppedFloors)
        {
            //有等待的人或者有乘坐的人
            while (_waitingPeoples.Count > 0 || _ridingPeoples.Count > 0)
            {
                var needStop = ExitArrivedPeople();
                if (_ridingPeoples.Count < _capacity)
                {
                    foreach (var currentFloorWaitingPeople in _waitingPeoples
                        .Where(p => p.StandingFloor == CurrentFloor && p.Direction == Direction).ToList())
                    {
                        if (!EntryOnePeople(currentFloorWaitingPeople)) break;
                        needStop = true;
                        _waitingPeoples.Remove(currentFloorWaitingPeople);
                    }
                }
                else
                {
                    if (_waitingPeoples.Any(p => p.StandingFloor == CurrentFloor && p.Direction == Direction))
                    {
                        needStop = true;
                    }
                }

                if (needStop && stoppedFloors.Last() != CurrentFloor) stoppedFloors.Add(CurrentFloor);
                GotoNextFloor();
            }

            //最终回到ground层
            if (stoppedFloors.Last() != 0) stoppedFloors.Add(0);
        }
    }

    /// <summary>
    /// 坐电梯的人
    /// </summary>
    public class People
    {
        public People(int standingFloor, int wannaFloor)
        {
            StandingFloor = standingFloor;
            WannaFloor = wannaFloor;
            Direction = standingFloor > wannaFloor ? -1 : 1;
        }

        /// <summary>
        /// 站立的楼层
        /// </summary>
        public int StandingFloor { get; private set; }

        /// <summary>
        /// 想去的楼层
        /// </summary>
        public int WannaFloor { get; private set; }

        /// <summary>
        /// 方向
        /// 1:向上
        /// -1:向下
        /// </summary>
        public int Direction { get; private set; }
    }
}
