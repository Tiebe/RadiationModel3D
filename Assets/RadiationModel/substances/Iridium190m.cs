using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium190m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium190m";
        public override double halfLife { get; } = 4032.0d;
        public override double atomicWeight { get; } = 189.96057d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium190()), new(1.01e-06d, new GammaParticle(26100.0, 0.0475)), new(0.22521080999999998d, new GammaParticle(10728.0, 0.11557)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    