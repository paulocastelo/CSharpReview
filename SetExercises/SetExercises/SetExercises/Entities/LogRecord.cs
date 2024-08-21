namespace SetExercises.Entities {
    class LogRecord {
        public string Username { get; set; }
        public DateTime Instant { get; set; }

        public LogRecord(string name, DateTime instant) {
            Username = name;
            Instant = instant;
        }

        public override int GetHashCode() {
            return Username.GetHashCode();
        }

        public override bool Equals(object obj) {
            if (!(obj is LogRecord)) {
                return false;
            }

            LogRecord other = obj as LogRecord;
            return Username.Equals(other.Username);
        }
        public override string ToString() {
            string str = Username + " - " + Instant;
            return str;
        }
    }
}
