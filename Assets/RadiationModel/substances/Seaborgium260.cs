using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Seaborgium260 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium260";
        public override double halfLife { get; } = 0.0036d;
        public override double atomicWeight { get; } = 260.11438d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.5d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rutherfordium256()), new(1.0d, new AlphaParticle(10922002.09)) } },
            { 0.5d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    