using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neodymium135m : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium135m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 134.91825d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9997d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cerium135()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0003d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neodymium135()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    