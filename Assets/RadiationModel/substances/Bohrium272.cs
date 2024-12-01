using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bohrium272 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium272";
        public override double halfLife { get; } = 10.5d;
        public override double atomicWeight { get; } = 272.13826d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Dubnium268()), new(1.0d, new AlphaParticle(10327002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    