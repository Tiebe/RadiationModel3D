using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium161";
        public override double halfLife { get; } = 8928.0d;
        public override double atomicWeight { get; } = 160.92786d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Dysprosium161()), new(0.0014000000000000002d, new GammaParticle(18150.0, 0.06831)), new(0.273d, new GammaParticle(25655.0, 0.04833)), new(0.00012d, new GammaParticle(28680.0, 0.04323)), new(0.0039000000000000003d, new GammaParticle(43800.0, 0.02831)), new(0.00117d, new GammaParticle(48860.0, 0.02538)), new(0.00010999999999999999d, new GammaParticle(56640.0, 0.02189)), new(0.000546d, new GammaParticle(57200.0, 0.02168)), new(0.006045d, new GammaParticle(59230.0, 0.02093)), new(4.7999999999999994e-05d, new GammaParticle(69290.0, 0.01789)), new(0.00117d, new GammaParticle(74577.0, 0.01662)), new(0.019110000000000002d, new GammaParticle(77420.0, 0.01601)), new(0.000546d, new GammaParticle(81230.0, 0.01526)), new(1.9e-05d, new GammaParticle(83830.0, 0.01479)), new(0.0001209d, new GammaParticle(87930.0, 0.0141)), new(0.0015210000000000002d, new GammaParticle(98020.0, 0.01265)), new(0.000546d, new GammaParticle(100390.0, 0.01235)), new(0.000546d, new GammaParticle(100640.0, 0.01232)), new(0.039d, new GammaParticle(103050.0, 0.01203)), new(4.2e-05d, new GammaParticle(106230.0, 0.01167)), new(3.9e-06d, new GammaParticle(107740.0, 0.01151)), new(2.5e-05d, new GammaParticle(109830.0, 0.01129)), new(3.51e-05d, new GammaParticle(112520.0, 0.01102)), new(9.75e-06d, new GammaParticle(119610.0, 0.01037)), new(1.17e-05d, new GammaParticle(131800.0, 0.00941)), new(0.00017549999999999998d, new GammaParticle(138390.0, 0.00896)), new(2.34e-05d, new GammaParticle(140400.0, 0.00883)), new(0.004875d, new GammaParticle(157260.0, 0.00788)), new(0.004329d, new GammaParticle(175420.0, 0.00707)), new(8.19e-05d, new GammaParticle(183000.0, 0.00678)), new(1.677e-05d, new GammaParticle(187300.0, 0.00662)), new(9.36e-06d, new GammaParticle(212800.0, 0.00583)), new(1.17e-06d, new GammaParticle(217600.0, 0.0057)), new(7.0200000000000006e-06d, new GammaParticle(238400.0, 0.0052)), new(1.95e-06d, new GammaParticle(252000.0, 0.00492)), new(6.629999999999999e-06d, new GammaParticle(319600.0, 0.00388)), new(5.07e-06d, new GammaParticle(577900.0, 0.00215)), new(2.379e-05d, new GammaParticle(658950.0, 0.00188)), new(1.17e-06d, new GammaParticle(669000.0, 0.00185)), new(1.7550000000000001e-06d, new GammaParticle(672500.0, 0.00184)), new(4.875e-05d, new GammaParticle(687500.0, 0.0018)), new(3.744e-05d, new GammaParticle(716090.0, 0.00173)), new(9.75e-06d, new GammaParticle(728200.0, 0.0017)), new(4.758e-05d, new GammaParticle(746980.0, 0.00166)), new(0.00017042999999999998d, new GammaParticle(764960.0, 0.00162)), new(6.629999999999999e-06d, new GammaParticle(772100.0, 0.00161)), new(0.00014078999999999999d, new GammaParticle(790680.0, 0.00157)), new(0.29d, new GammaParticle(7384.0, 0.16791)), new(0.24d, new GammaParticle(45207.0, 0.02743)), new(0.44d, new GammaParticle(45998.0, 0.02695)), new(0.14d, new GammaParticle(52220.0, 0.02374)), new(0.177d, new GammaParticle(52791.0, 0.02349)), new(0.036000000000000004d, new GammaParticle(53478.0, 0.02318)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    