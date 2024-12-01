using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Seaborgium267 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium267";
        public override double halfLife { get; } = 84.0d;
        public override double atomicWeight { get; } = 267.12433d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.83d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.17d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rutherfordium263()), new(1.0d, new AlphaParticle(9647002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    