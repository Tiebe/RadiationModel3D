using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth184 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth184";
        public override double halfLife { get; } = 0.013d;
        public override double atomicWeight { get; } = 184.00134d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium180()), new(1.0d, new AlphaParticle(9237002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    