using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Uranium216 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium216";
        public override double halfLife { get; } = 0.0045d;
        public override double atomicWeight { get; } = 216.02476d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thorium212()), new(1.0d, new AlphaParticle(9552002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    