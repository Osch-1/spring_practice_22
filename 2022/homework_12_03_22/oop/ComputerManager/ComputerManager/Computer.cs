using ComputerManager.Parts.GraphicalCards;
using ComputerManager.Parts.Motherboards;
using ComputerManager.Parts.Processors;
using ComputerManager.Parts.Rams;

namespace ComputerManager;

public class Computer
{
    public Motherboard Motherboard { get; private set; } // init
    public Processor Processor { get; private set; }
    public GraphicalCard GraphicalCard { get; private set; }
    public RandomAccessMemory RandomAccessMemory { get; private set; }

    public Computer
    (
        Motherboard motherboard,
        Processor processor,
        GraphicalCard graphicalCard,
        RandomAccessMemory randomAccessMemory
    )
    {
        Motherboard = motherboard ?? throw new ArgumentNullException( nameof( motherboard ) );
        Processor = processor ?? throw new ArgumentNullException( nameof( processor ) );
        GraphicalCard = graphicalCard ?? throw new ArgumentNullException( nameof( graphicalCard ) );
        RandomAccessMemory = randomAccessMemory ?? throw new ArgumentNullException( nameof( randomAccessMemory ) );
    }

    public string GetInfo()
    {
        throw new NotImplementedException();
    }
}
