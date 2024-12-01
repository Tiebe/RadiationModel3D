using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Moscovium289 : RadioactiveSubstance
    {
        public override string name { get; } = "Moscovium289";
        public override double halfLife { get; } = 0.296d;
        public override double atomicWeight { get; } = 289.19397d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nihonium285()), new(1.0d, new AlphaParticle(11507002.09)) } },
            { 0.05d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    