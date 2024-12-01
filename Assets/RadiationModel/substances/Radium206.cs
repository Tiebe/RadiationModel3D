using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium206 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium206";
        public override double halfLife { get; } = 0.24d;
        public override double atomicWeight { get; } = 206.00383d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon202()), new(1.0d, new AlphaParticle(8438002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    