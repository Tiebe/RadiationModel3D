using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver113m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver113m";
        public override double halfLife { get; } = 68.7d;
        public override double atomicWeight { get; } = 112.90662d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.64d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver113()), new(0.0040999999999999995d, new GammaParticle(43600.0, 0.02844)), new(0.1880592428d, new GammaParticle(3218.0, 0.38528)), new(0.08765923918132006d, new GammaParticle(21990.0, 0.05638)), new(0.1652389051485769d, new GammaParticle(22163.0, 0.05594)), new(0.04577585661848646d, new GammaParticle(25030.0, 0.04953)), new(0.053740855670103095d, new GammaParticle(25211.0, 0.04918)), new(0.007964999051616644d, new GammaParticle(25454.0, 0.04871)) } },
            { 0.36d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cadmium113()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.008d, new GammaParticle(17800.0, 0.06965)), new(0.0034999999999999996d, new GammaParticle(126000.0, 0.00984)), new(0.028999999999999998d, new GammaParticle(142200.0, 0.00872)), new(0.0034999999999999996d, new GammaParticle(188000.0, 0.00659)), new(0.0111d, new GammaParticle(249900.0, 0.00496)), new(0.0034999999999999996d, new GammaParticle(268000.0, 0.00463)), new(0.0013d, new GammaParticle(285000.0, 0.00435)), new(0.10099999999999999d, new GammaParticle(298300.0, 0.00416)), new(0.18d, new GammaParticle(316100.0, 0.00392)), new(0.111d, new GammaParticle(392300.0, 0.00316)), new(0.0067d, new GammaParticle(410000.0, 0.00302)), new(0.0018d, new GammaParticle(423000.0, 0.00293)), new(0.0039000000000000003d, new GammaParticle(487000.0, 0.00255)), new(0.0034999999999999996d, new GammaParticle(549000.0, 0.00226)), new(0.036000000000000004d, new GammaParticle(583800.0, 0.00212)), new(0.0018d, new GammaParticle(589000.0, 0.0021)), new(0.0072d, new GammaParticle(690800.0, 0.00179)), new(0.035d, new GammaParticle(708300.0, 0.00175)), new(0.0088d, new GammaParticle(709000.0, 0.00175)), new(0.0062d, new GammaParticle(731300.0, 0.0017)), new(0.0034999999999999996d, new GammaParticle(737000.0, 0.00168)), new(0.0034999999999999996d, new GammaParticle(897000.0, 0.00138)), new(0.0047420394323999995d, new GammaParticle(3388.0, 0.36595)), new(0.002564550939437423d, new GammaParticle(22983.0, 0.05395)), new(0.0048233043811123245d, new GammaParticle(23173.0, 0.0535)), new(0.0013444396611254237d, new GammaParticle(26184.0, 0.04735)), new(0.0015891276794502507d, new GammaParticle(26381.0, 0.047)), new(0.0002446880183248271d, new GammaParticle(26641.0, 0.04654)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    