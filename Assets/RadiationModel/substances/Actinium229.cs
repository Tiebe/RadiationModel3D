using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium229 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium229";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 229.03295d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    