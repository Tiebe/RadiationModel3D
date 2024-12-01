using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium177 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium177";
        public override double halfLife { get; } = 180.0d;
        public override double atomicWeight { get; } = 176.95496d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten177()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    