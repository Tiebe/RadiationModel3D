using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium179 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium179";
        public override double halfLife { get; } = 390.0d;
        public override double atomicWeight { get; } = 178.95382d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten179()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    