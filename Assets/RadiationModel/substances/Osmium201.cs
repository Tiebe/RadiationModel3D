using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium201 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium201";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 200.98407d;

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
    