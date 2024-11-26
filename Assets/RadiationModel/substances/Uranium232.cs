using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium232 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium232";
        public override double halfLife { get; } = 2174272199.64939d;
        public override double atomicWeight { get; } = 232.03715d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thorium228() }, { 1.0d, new AlphaParticle(6435502.09) }, { 0.0019994799999999997d, new GammaParticle(57780.0, 0.02146) }, { 0.000681947d, new GammaParticle(129080.0, 0.00961) }, { 3.1080000000000004e-08d, new GammaParticle(141000.0, 0.00879) }, { 3.108e-07d, new GammaParticle(191000.0, 0.00649) }, { 1.0619e-07d, new GammaParticle(209500.0, 0.00592) }, { 3.1598e-05d, new GammaParticle(270200.0, 0.00459) }, { 2.8308700000000002e-05d, new GammaParticle(327900.0, 0.00378) }, { 4.921e-07d, new GammaParticle(332300.0, 0.00373) }, { 3.7037e-07d, new GammaParticle(338100.0, 0.00367) }, { 1.4245000000000001e-08d, new GammaParticle(478000.0, 0.00259) }, { 1.4504e-07d, new GammaParticle(503600.0, 0.00246) }, { 1.0101e-08d, new GammaParticle(547000.0, 0.00227) }, { 4.6619999999999997e-08d, new GammaParticle(773400.0, 0.0016) }, { 7.770000000000001e-09d, new GammaParticle(817000.0, 0.00152) }, { 7.770000000000001e-09d, new GammaParticle(831000.0, 0.00149) }, { 0.10940460977853554d, new GammaParticle(15784.0, 0.07855) }, { 5.304777833019863e-05d, new GammaParticle(89954.0, 0.01378) }, { 8.581005876771049e-05d, new GammaParticle(93347.0, 0.01328) }, { 3.0534184073885775e-05d, new GammaParticle(105566.0, 0.01174) }, { 4.082420410678528e-05d, new GammaParticle(106894.0, 0.0116) }, { 1.0290020032899508e-05d, new GammaParticle(108580.0, 0.01142) } } },
            { 8.9e-12d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 2.7e-14d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    