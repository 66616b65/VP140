using System;
using System.IO;

namespace DisposeExample
{
    class FileClass : AbstractFileClass, IDisposable
    {
        private bool _isDisposed = false;
        private TextWriter _writer;
        private TextReader _reader;
        private int[] _largeArray;

        public void Write()
        {
            //Проверяем, что объект не был уничтожен
            if (_isDisposed)
            {
                throw new ObjectDisposedException("This file is disposed");
            }
        }

        public void Read()
        {
            //Проверяем, что объект не был уничтожен
            if (_isDisposed)
            {
                throw new ObjectDisposedException("This file is disposed");
            }
        }

        public new void Dispose()
        {
            Dispose(true);
            //Не отправлять объект в очередь финализации
            GC.SuppressFinalize(this);
        }

        ~FileClass()
        {
            Dispose(false);
        }

        protected new virtual void Dispose(bool isDisposing)
        {
            if (!_isDisposed)
            {
                if (isDisposing)
                {
                    //Освобождаем управляемые ресурсы
                    //если метод вызван вручную, а не в финализаторе
                    _largeArray = null;
                }

                //Освобождаем неуправляемые ресурсы
                if (_writer != null)
                {
                    _writer.Flush();
                    _writer.Close();
                    _writer = null;
                }

                //Освобождаем неуправляемые ресурсы
                if (_reader != null)
                {
                    _reader.Close();
                    _reader = null;
                }

                //Ресурсы были освобождены
                _isDisposed = true;

                //вызываем метод Dispose базового класса
                base.Dispose(isDisposing);
            }
        }

        void Method()
        {
            //вот это
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"D:/folder/file.txt", FileMode.OpenOrCreate);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
            }

            //равносильно этому
            using (var f = new FileStream(@"D:/folder/file.txt", FileMode.OpenOrCreate))
            {

            }
            
        }
    }
}
