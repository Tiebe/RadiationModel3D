using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lawrencium255p : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium255p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 255.09813d;

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
    