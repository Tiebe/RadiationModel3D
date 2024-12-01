using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tungsten180m : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten180m";
        public override double halfLife { get; } = 0.00547d;
        public override double atomicWeight { get; } = 179.94835d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten180()), new(0.228d, new GammaParticle(103568.0, 0.01197)), new(1.14d, new GammaParticle(233990.0, 0.0053)), new(1.1514d, new GammaParticle(350898.0, 0.00353)), new(1.14d, new GammaParticle(390581.0, 0.00317)), new(1.3337999999999999d, new GammaParticle(450018.0, 0.00276)), new(0.24309618637500002d, new GammaParticle(9740.0, 0.12729)), new(0.10929762642187768d, new GammaParticle(57983.0, 0.02138)), new(0.1898517047453147d, new GammaParticle(59320.0, 0.0209)), new(0.06292937264741567d, new GammaParticle(67335.0, 0.01841)), new(0.08017202075280756d, new GammaParticle(68117.0, 0.0182)), new(0.017242648105391896d, new GammaParticle(69068.0, 0.01795)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    