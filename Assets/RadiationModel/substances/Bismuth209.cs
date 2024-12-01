using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth209 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth209";
        public override double halfLife { get; } = 6.342942120892992e+26d;
        public override double atomicWeight { get; } = 208.9804d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium205()), new(1.0d, new AlphaParticle(4159202.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    