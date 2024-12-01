using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium219m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium219m";
        public override double halfLife { get; } = 0.01d;
        public override double atomicWeight { get; } = 219.0101d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon215()), new(1.0d, new AlphaParticle(9177002.09)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    