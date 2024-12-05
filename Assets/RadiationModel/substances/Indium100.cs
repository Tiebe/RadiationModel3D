using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium100 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium100";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 99.9311d;

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
    