using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ytterbium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium157";
        public override double halfLife { get; } = 38.6d;
        public override double atomicWeight { get; } = 156.94265d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.995d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Erbium157()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.23d, new GammaParticle(23390.0, 0.05301)), new(0.05d, new GammaParticle(26050.0, 0.04759)), new(0.005d, new GammaParticle(35200.0, 0.03522)), new(0.05d, new GammaParticle(44020.0, 0.02817)), new(0.03d, new GammaParticle(69520.0, 0.01783)), new(0.013999999999999999d, new GammaParticle(101000.0, 0.01228)), new(0.03d, new GammaParticle(105700.0, 0.01173)), new(0.04d, new GammaParticle(115200.0, 0.01076)), new(0.003d, new GammaParticle(116780.0, 0.01062)), new(0.026000000000000002d, new GammaParticle(129260.0, 0.00959)), new(0.006d, new GammaParticle(133020.0, 0.00932)), new(0.005d, new GammaParticle(156820.0, 0.00791)), new(0.06d, new GammaParticle(164490.0, 0.00754)), new(0.026000000000000002d, new GammaParticle(189330.0, 0.00655)), new(0.004d, new GammaParticle(196470.0, 0.00631)), new(0.021d, new GammaParticle(202300.0, 0.00613)), new(0.004d, new GammaParticle(206230.0, 0.00601)), new(0.013999999999999999d, new GammaParticle(227310.0, 0.00545)), new(0.09d, new GammaParticle(231100.0, 0.00536)), new(0.006d, new GammaParticle(239100.0, 0.00519)), new(0.09d, new GammaParticle(242050.0, 0.00512)), new(0.006999999999999999d, new GammaParticle(248070.0, 0.005)), new(0.011000000000000001d, new GammaParticle(249910.0, 0.00496)), new(0.018000000000000002d, new GammaParticle(258320.0, 0.0048)), new(0.008d, new GammaParticle(273100.0, 0.00454)), new(0.04d, new GammaParticle(280700.0, 0.00442)), new(0.011000000000000001d, new GammaParticle(285930.0, 0.00434)), new(0.06d, new GammaParticle(339950.0, 0.00365)), new(0.04d, new GammaParticle(341860.0, 0.00363)), new(0.021d, new GammaParticle(348360.0, 0.00356)), new(0.04d, new GammaParticle(353900.0, 0.0035)), new(0.03d, new GammaParticle(357700.0, 0.00347)), new(0.04d, new GammaParticle(361020.0, 0.00343)), new(0.01d, new GammaParticle(385930.0, 0.00321)), new(0.006d, new GammaParticle(388100.0, 0.00319)), new(0.013000000000000001d, new GammaParticle(395250.0, 0.00314)), new(0.009000000000000001d, new GammaParticle(405840.0, 0.00306)), new(0.006999999999999999d, new GammaParticle(430500.0, 0.00288)), new(0.013999999999999999d, new GammaParticle(447790.0, 0.00277)), new(0.013000000000000001d, new GammaParticle(458150.0, 0.00271)), new(0.017d, new GammaParticle(474620.0, 0.00261)), new(0.009000000000000001d, new GammaParticle(475400.0, 0.00261)), new(0.009000000000000001d, new GammaParticle(480980.0, 0.00258)), new(0.015d, new GammaParticle(492370.0, 0.00252)), new(0.011000000000000001d, new GammaParticle(525130.0, 0.00236)), new(0.015d, new GammaParticle(535130.0, 0.00232)), new(0.019d, new GammaParticle(670200.0, 0.00185)) } },
            { 0.005d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Erbium153()), new(1.0d, new AlphaParticle(5644002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    