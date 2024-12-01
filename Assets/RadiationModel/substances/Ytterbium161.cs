using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ytterbium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium161";
        public override double halfLife { get; } = 252.0d;
        public override double atomicWeight { get; } = 160.93791d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Erbium161()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    