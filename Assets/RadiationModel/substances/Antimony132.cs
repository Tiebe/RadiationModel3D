using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Antimony132 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony132";
        public override double halfLife { get; } = 167.4d;
        public override double atomicWeight { get; } = 131.91451d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium132()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.35d, new GammaParticle(103519.0, 0.01198)), new(0.66d, new GammaParticle(150672.0, 0.00823)), new(0.04d, new GammaParticle(276000.0, 0.00449)), new(0.04d, new GammaParticle(293000.0, 0.00423)), new(0.07d, new GammaParticle(368600.0, 0.00336)), new(0.07d, new GammaParticle(382300.0, 0.00324)), new(0.13d, new GammaParticle(496500.0, 0.0025)), new(1.0d, new GammaParticle(697052.0, 0.00178)), new(0.03d, new GammaParticle(775800.0, 0.0016)), new(0.06d, new GammaParticle(881900.0, 0.00141)), new(0.03d, new GammaParticle(926200.0, 0.00134)), new(1.0d, new GammaParticle(973900.0, 0.00127)), new(0.18d, new GammaParticle(1041500.0, 0.00119)), new(0.1d, new GammaParticle(1166900.0, 0.00106)), new(0.04d, new GammaParticle(1378800.0, 0.0009)), new(0.04d, new GammaParticle(1763700.0, 0.0007)), new(0.02d, new GammaParticle(1854600.0, 0.00067)), new(0.04d, new GammaParticle(2664000.0, 0.00047)), new(0.047d, new GammaParticle(4135.0, 0.29984)), new(0.105d, new GammaParticle(27202.0, 0.04558)), new(0.2d, new GammaParticle(27473.0, 0.04513)), new(0.055999999999999994d, new GammaParticle(31093.0, 0.03988)), new(0.068d, new GammaParticle(31359.0, 0.03954)), new(0.0121d, new GammaParticle(31698.0, 0.03911)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    