
namespace GliInvincibili.Model.src
{

    public class Player
    {
        public string Name { get; private set; }

        public Player(string name)
        {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            try
            {
                return (obj is Player) &&
                    (obj as Player).Name.ToLower() == Name.ToLower();
            }
            catch
            {
                return false;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
