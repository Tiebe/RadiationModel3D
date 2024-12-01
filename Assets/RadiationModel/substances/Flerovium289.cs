using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Flerovium289 : RadioactiveSubstance
    {
        public override string name { get; } = "Flerovium289";
        public override double halfLife { get; } = 2.4d;
        public override double atomicWeight { get; } = 289.19052d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Copernicium285()), new(1.0d, new AlphaParticle(10977002.09)) } },
            { 0.06d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    