using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Uranium232 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium232";
        public override double halfLife { get; } = 2174272199.64939d;
        public override double atomicWeight { get; } = 232.03715d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thorium228()), new(1.0d, new AlphaParticle(6435502.09)), new(0.0019994799999999997d, new GammaParticle(57780.0, 0.02146)), new(0.000681947d, new GammaParticle(129080.0, 0.00961)), new(3.1080000000000004e-08d, new GammaParticle(141000.0, 0.00879)), new(3.108e-07d, new GammaParticle(191000.0, 0.00649)), new(1.0619e-07d, new GammaParticle(209500.0, 0.00592)), new(3.1598e-05d, new GammaParticle(270200.0, 0.00459)), new(2.8308700000000002e-05d, new GammaParticle(327900.0, 0.00378)), new(4.921e-07d, new GammaParticle(332300.0, 0.00373)), new(3.7037e-07d, new GammaParticle(338100.0, 0.00367)), new(1.4245000000000001e-08d, new GammaParticle(478000.0, 0.00259)), new(1.4504e-07d, new GammaParticle(503600.0, 0.00246)), new(1.0101e-08d, new GammaParticle(547000.0, 0.00227)), new(4.6619999999999997e-08d, new GammaParticle(773400.0, 0.0016)), new(7.770000000000001e-09d, new GammaParticle(817000.0, 0.00152)), new(7.770000000000001e-09d, new GammaParticle(831000.0, 0.00149)), new(0.10940460977853554d, new GammaParticle(15784.0, 0.07855)), new(5.304777833019863e-05d, new GammaParticle(89954.0, 0.01378)), new(8.581005876771049e-05d, new GammaParticle(93347.0, 0.01328)), new(3.0534184073885775e-05d, new GammaParticle(105566.0, 0.01174)), new(4.082420410678528e-05d, new GammaParticle(106894.0, 0.0116)), new(1.0290020032899508e-05d, new GammaParticle(108580.0, 0.01142)) } },
            { 8.9e-12d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 2.7e-14d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    