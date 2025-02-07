using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium214 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium214";
        public override double halfLife { get; } = 2.438d;
        public override double atomicWeight { get; } = 214.0001d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.99941d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon210()), new(1.0d, new AlphaParticle(8295002.09)), new(0.002d, new GammaParticle(642800.0, 0.00193)), new(1.3462996799999998e-05d, new GammaParticle(14088.0, 0.08801)), new(8.20800287020093e-06d, new GammaParticle(81070.0, 0.01529)), new(1.3540090515013081e-05d, new GammaParticle(83789.0, 0.0148)), new(4.69561107180757e-06d, new GammaParticle(94878.0, 0.01307)), new(6.198206614785993e-06d, new GammaParticle(96054.0, 0.01291)), new(1.5025955429784225e-06d, new GammaParticle(97530.0, 0.01271)) } },
            { 0.0005899999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Francium214()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    