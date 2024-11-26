using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold200m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold200m";
        public override double halfLife { get; } = 67320.0d;
        public override double atomicWeight { get; } = 199.97184d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.84d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury200() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) }, { 0.019d, new GammaParticle(111120.0, 0.01116) }, { 0.541d, new GammaParticle(181180.0, 0.00684) }, { 0.7240000000000001d, new GammaParticle(255870.0, 0.00485) }, { 0.7929999999999999d, new GammaParticle(367942.0, 0.00337) }, { 0.818d, new GammaParticle(497770.0, 0.00249) }, { 0.8240000000000001d, new GammaParticle(579300.0, 0.00214) }, { 0.746d, new GammaParticle(759500.0, 0.00163) }, { 0.08800000000000001d, new GammaParticle(904230.0, 0.00137) }, { 0.13510564961992d, new GammaParticle(11777.0, 0.10528) }, { 0.0603602503483443d, new GammaParticle(68894.0, 0.018) }, { 0.10232285192124817d, new GammaParticle(70820.0, 0.01751) }, { 0.03472585941717519d, new GammaParticle(80316.0, 0.01544) }, { 0.04490053622640752d, new GammaParticle(81285.0, 0.01525) }, { 0.010174676809232331d, new GammaParticle(82477.0, 0.01503) } } },
            { 0.16d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold200() }, { 0.0053d, new GammaParticle(60080.0, 0.02064) }, { 0.0011d, new GammaParticle(84250.0, 0.01472) }, { 0.00125d, new GammaParticle(101430.0, 0.01222) }, { 0.0015d, new GammaParticle(105420.0, 0.01176) }, { 0.0018d, new GammaParticle(120280.0, 0.01031) }, { 0.0052d, new GammaParticle(133230.0, 0.00931) }, { 0.0021d, new GammaParticle(137280.0, 0.00903) }, { 0.0018d, new GammaParticle(144600.0, 0.00857) }, { 0.0063d, new GammaParticle(146070.0, 0.00849) }, { 0.0029d, new GammaParticle(218510.0, 0.00567) }, { 0.022000000000000002d, new GammaParticle(332820.0, 0.00373) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    