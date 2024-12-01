using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium206 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium206";
        public override double halfLife { get; } = 0.022d;
        public override double atomicWeight { get; } = 206.01447d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Francium202()), new(1.0d, new AlphaParticle(8975002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    