using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Samarium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium161";
        public override double halfLife { get; } = 4.8d;
        public override double atomicWeight { get; } = 160.93916d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Europium161()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    