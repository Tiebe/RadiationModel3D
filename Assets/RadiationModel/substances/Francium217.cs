using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Francium217 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium217";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 217.00463d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Astatine213()), new(1.0d, new AlphaParticle(9492002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    