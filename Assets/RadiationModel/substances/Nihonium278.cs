using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nihonium278 : RadioactiveSubstance
    {
        public override string name { get; } = "Nihonium278";
        public override double halfLife { get; } = 0.0014d;
        public override double atomicWeight { get; } = 278.17073d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Roentgenium274()), new(1.0d, new AlphaParticle(13017002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    