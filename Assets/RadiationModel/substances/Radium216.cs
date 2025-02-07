using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium216 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium216";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 216.00353d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon212()), new(1.0d, new AlphaParticle(10547002.09)) } },
            { 1e-10d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Francium216()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    