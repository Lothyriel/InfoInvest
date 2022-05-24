using Core.Model;

namespace Assets.Model
{
    public class Asset : Entity
    {
        public Asset(Guid id, string name, Group group) : base(id)
        {
            Name = name;
            Group = group;
        }

        public string Name { get; set; }
        public Group Group { get; set; }
    }

    public enum Group
    {
        RendaFixa,
        RendaVariavel,
        Fundos,
        Acoes,
        TesouroDireto,
        Poupanca,
        Criptomoeda
    }
}