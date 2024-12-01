using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neptunium237 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium237";
        public override double halfLife { get; } = 67658049289525.25d;
        public override double atomicWeight { get; } = 237.04817d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Protactinium233()), new(1.0d, new AlphaParticle(5979202.09)), new(5.4999999999999995e-05d, new GammaParticle(8220.0, 0.15083)), new(0.00356d, new GammaParticle(21500.0, 0.05767)), new(0.0084d, new GammaParticle(27700.0, 0.04476)), new(0.145d, new GammaParticle(29374.0, 0.04221)), new(5e-05d, new GammaParticle(36320.0, 0.03414)), new(0.00109d, new GammaParticle(46530.0, 0.02665)), new(0.00362d, new GammaParticle(57113.0, 0.02171)), new(6e-05d, new GammaParticle(62590.0, 0.01981)), new(0.00010800000000000001d, new GammaParticle(63900.0, 0.0194)), new(0.00010800000000000001d, new GammaParticle(70490.0, 0.01759)), new(0.00012d, new GammaParticle(74540.0, 0.01663)), new(0.122d, new GammaParticle(86484.0, 0.01434)), new(0.00148d, new GammaParticle(87990.0, 0.01409)), new(0.0059099999999999995d, new GammaParticle(94650.0, 0.0131)), new(0.00048d, new GammaParticle(106120.0, 0.01168)), new(0.0007099999999999999d, new GammaParticle(108700.0, 0.01141)), new(2.6e-05d, new GammaParticle(115440.0, 0.01074)), new(0.0017000000000000001d, new GammaParticle(117705.0, 0.01053)), new(0.000849d, new GammaParticle(131093.0, 0.00946)), new(0.0007199999999999999d, new GammaParticle(134276.0, 0.00923)), new(4.6e-05d, new GammaParticle(139900.0, 0.00886)), new(0.00416d, new GammaParticle(143248.0, 0.00866)), new(0.00244d, new GammaParticle(151408.0, 0.00819)), new(6.1000000000000005e-05d, new GammaParticle(153370.0, 0.00808)), new(0.000887d, new GammaParticle(155242.0, 0.00799)), new(0.00032599999999999996d, new GammaParticle(162510.0, 0.00763)), new(0.000621d, new GammaParticle(169156.0, 0.00733)), new(0.0002d, new GammaParticle(170620.0, 0.00727)), new(0.00016d, new GammaParticle(176090.0, 0.00704)), new(0.000156d, new GammaParticle(180790.0, 0.00686)), new(3e-05d, new GammaParticle(186860.0, 0.00664)), new(0.00018700000000000002d, new GammaParticle(191430.0, 0.00648)), new(0.00043700000000000005d, new GammaParticle(193240.0, 0.00642)), new(0.00033d, new GammaParticle(194670.0, 0.00637)), new(0.00182d, new GammaParticle(194960.0, 0.00636)), new(0.00020899999999999998d, new GammaParticle(196850.0, 0.0063)), new(5.3e-05d, new GammaParticle(199950.0, 0.0062)), new(0.000394d, new GammaParticle(201670.0, 0.00615)), new(4.7999999999999994e-05d, new GammaParticle(202900.0, 0.00611)), new(0.000142d, new GammaParticle(209200.0, 0.00593)), new(0.0015199999999999999d, new GammaParticle(212320.0, 0.00584)), new(0.000357d, new GammaParticle(214010.0, 0.00579)), new(2e-05d, new GammaParticle(222600.0, 0.00557)), new(0.00010999999999999999d, new GammaParticle(229940.0, 0.00539)), new(0.000572d, new GammaParticle(237884.0, 0.00521)), new(5e-05d, new GammaParticle(248930.0, 0.00498)), new(6.4e-05d, new GammaParticle(257090.0, 0.00482)), new(4.71e-05d, new GammaParticle(262440.0, 0.00472)), new(0.00010899999999999999d, new GammaParticle(279650.0, 0.00443)), new(0.000164d, new GammaParticle(288300.0, 0.0043)), new(0.48469568294385196d, new GammaParticle(16228.0, 0.0764)), new(0.01397406408405659d, new GammaParticle(92282.0, 0.01344)), new(0.022488033608073044d, new GammaParticle(95865.0, 0.01293)), new(0.008060329288178023d, new GammaParticle(108373.0, 0.01144)), new(0.010792780916870373d, new GammaParticle(109740.0, 0.0113)), new(0.0027324516286923502d, new GammaParticle(111482.0, 0.01112)) } },
            { 2e-12d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    