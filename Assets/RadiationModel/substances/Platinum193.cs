using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum193 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum193";
        public override double halfLife { get; } = 1577846298.7296d;
        public override double atomicWeight { get; } = 192.96298d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium193()), new(0.2156759d, new GammaParticle(10728.0, 0.11557)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    