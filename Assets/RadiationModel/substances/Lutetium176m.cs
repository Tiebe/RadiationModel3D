using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium176m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium176m";
        public override double halfLife { get; } = 13190.4d;
        public override double atomicWeight { get; } = 175.94282d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.99905d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium176()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.089024d, new GammaParticle(88361.0, 0.01403)), new(6.955e-06d, new GammaParticle(202200.0, 0.00613)), new(2.1977800000000002e-06d, new GammaParticle(936250.0, 0.00132)), new(4.4511999999999995e-07d, new GammaParticle(956800.0, 0.0013)), new(7.622679999999999e-06d, new GammaParticle(1061420.0, 0.00117)), new(2.33688e-06d, new GammaParticle(1138250.0, 0.00109)), new(1.391e-05d, new GammaParticle(1159260.0, 0.00107)), new(9.3197e-07d, new GammaParticle(1204700.0, 0.00103)), new(1.3214499999999999e-06d, new GammaParticle(1226610.0, 0.00101)), new(2.0865e-07d, new GammaParticle(1247620.0, 0.00099)), new(0.10300000000000001d, new GammaParticle(9114.0, 0.13604)), new(0.0287d, new GammaParticle(54608.0, 0.0227)), new(0.05d, new GammaParticle(55786.0, 0.02222)), new(0.0166d, new GammaParticle(63333.0, 0.01958)), new(0.021d, new GammaParticle(64057.0, 0.01936)), new(0.0044d, new GammaParticle(64935.0, 0.01909)) } },
            { 0.00095d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium176()), new(7.000000000000001e-05d, new GammaParticle(82100.0, 0.0151)), new(0.000273160812904d, new GammaParticle(8502.0, 0.14583)), new(0.00020675469287088612d, new GammaParticle(51354.0, 0.02414)), new(0.0003644538918929775d, new GammaParticle(52389.0, 0.02367)), new(0.00011963218654729292d, new GammaParticle(59481.0, 0.02084)), new(0.0001508561872361364d, new GammaParticle(60151.0, 0.02061)), new(3.122400068884345e-05d, new GammaParticle(60961.0, 0.02034)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    