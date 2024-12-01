using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radon216 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon216";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 216.00027d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium212()), new(1.0d, new AlphaParticle(9219402.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    