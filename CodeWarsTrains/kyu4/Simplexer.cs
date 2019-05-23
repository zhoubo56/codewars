using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace kyu4
{
    /// <summary>
    /// Simplexer
    /// https://www.codewars.com/kata/simplexer
    /// </summary>
    public class Simplexer
    {
        private readonly string _buffer;
        private int _beginIndex = 0;
        private int _currentIndex = 0;
        private string _currentType = string.Empty;

        public Simplexer(string buffer)
        {
            _buffer = buffer;
        }

        public bool MoveNext()
        {
            _beginIndex += _currentIndex;
            _currentIndex = 0;
            if (string.IsNullOrEmpty(_buffer) || _buffer.Length == _beginIndex)
            {
                return false;
            }
            else
            {
                return IsInteger(0) || IsBoolean() || IsString() || IsOperator() || IsKeyword() || IsWhitespace(0) || IsIdentifier();
            }
        }

        public Token Current
        {
            get
            {
                return new Token(_buffer.Substring(_beginIndex, _currentIndex), _currentType);
            }
        }

        private bool IsInteger(int begin)
        {
            if (_buffer.Length > (_beginIndex + begin) && "12345667890".Contains(_buffer.Substring(_beginIndex + begin, 1)))
            {
                _currentType = "integer";
                return IsInteger(begin + 1);
            }
            else
            {
                _currentIndex = begin;
                return begin > 0;
            }
        }

        private bool IsBoolean()
        {
            var isStartWith = IsStartsWith(new[] { "true", "false" });
            if (isStartWith)
            {
                _currentType = "boolean";
            }
            return isStartWith;
        }

        private bool IsString()
        {
            var isStartWith = IsStartsWith(new[] { "\"" });
            if (isStartWith)
            {
                var endFlag = _buffer.Substring(_beginIndex + _currentIndex).IndexOf("\"", StringComparison.Ordinal);
                if (endFlag > 0)
                {
                    _currentType = "string";
                    _currentIndex = _buffer.Substring(_beginIndex, _currentIndex + endFlag + 1).Length;
                    return true;
                }

                _currentIndex = 0;
            }

            return false;
        }

        private bool IsOperator()
        {
            var isStartWith = IsStartsWith(new[] { "+", "-", "*", "/", "(", ")", "=" });
            if (isStartWith)
            {
                _currentType = "operator";
            }
            return isStartWith;
        }

        private bool IsKeyword()
        {
            var isStartWith = IsStartsWith(new[] { "if", "else", "for", "while", "return", "func", "break" });
            if (isStartWith)
            {
                _currentType = "keyword";
            }
            return isStartWith;
        }

        private bool IsWhitespace(int begin)
        {
            if (_buffer.Length > (_beginIndex + begin) && IsStartsWith(new[] { " ", "\t", "\n" }, begin))
            {
                _currentType = "whitespace";
                return IsWhitespace(begin + _currentIndex);
            }
            else
            {
                _currentIndex = begin;
                return begin > 0;
            }
        }

        private bool IsIdentifier()
        {
            _currentType = "identifier";
            _currentIndex = 1;
            return true;
        }

        private bool IsStartsWith(string[] texts, int index = 0)
        {
            foreach (var flag in texts)
            {
                if (!_buffer.Substring(_beginIndex + index).StartsWith(flag)) continue;

                _currentIndex = flag.Length;
                return true;
            }

            return false;
        }
    }

    public class Token
    {
        public Token()
        {

        }

        public Token(string text, string type)
        {
            Text = text;
            Type = type;
        }

        public string Text { get; set; }

        public string Type { get; set; }

        public override bool Equals(object obj)
        {
            var token = (Token)obj;
            return null != token && Equals(token);
        }

        protected bool Equals(Token other)
        {
            return string.Equals(Text, other.Text) && string.Equals(Type, other.Type);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Text != null ? Text.GetHashCode() : 0) * 397) ^ (Type != null ? Type.GetHashCode() : 0);
            }
        }
    }
}
