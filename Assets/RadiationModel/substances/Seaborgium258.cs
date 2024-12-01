using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Seaborgium258 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium258";
        public override double halfLife { get; } = 0.0025d;
        public override double atomicWeight { get; } = 258.11304d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.2d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rutherfordium254()), new(1.0d, new AlphaParticle(10697002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    