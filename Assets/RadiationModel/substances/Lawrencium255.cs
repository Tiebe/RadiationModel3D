using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lawrencium255 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium255";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 255.09656d;

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
    