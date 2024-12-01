using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Fermium241 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium241";
        public override double halfLife { get; } = 0.00073d;
        public override double atomicWeight { get; } = 241.07431d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.78d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.14d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Californium237()), new(1.0d, new AlphaParticle(9877002.09)) } },
            { 0.12d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Einsteinium241()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    