using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium175 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium175";
        public override double halfLife { get; } = 9.0d;
        public override double atomicWeight { get; } = 174.96415d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9915d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium175()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0085d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium171()), new(1.0d, new AlphaParticle(6452002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    