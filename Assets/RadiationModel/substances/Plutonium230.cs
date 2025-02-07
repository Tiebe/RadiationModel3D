using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Plutonium230 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium230";
        public override double halfLife { get; } = 102.0d;
        public override double atomicWeight { get; } = 230.03965d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Uranium226()), new(1.0d, new AlphaParticle(8200002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    