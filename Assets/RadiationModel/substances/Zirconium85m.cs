using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zirconium85m : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium85m";
        public override double halfLife { get; } = 10.9d;
        public override double atomicWeight { get; } = 84.92176d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zirconium85()) } },
            { 0.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Strontium85()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    