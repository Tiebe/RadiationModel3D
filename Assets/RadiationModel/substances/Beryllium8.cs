using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Beryllium8 : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium8";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 8.00531d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Helium4()), new(1.0d, new AlphaParticle(1113756.22)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    