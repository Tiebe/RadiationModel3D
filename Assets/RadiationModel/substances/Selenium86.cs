using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium86 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium86";
        public override double halfLife { get; } = 14.3d;
        public override double atomicWeight { get; } = 85.92431d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine86() }, { 1.0d, new BetaParticle(-1, 2564400.0) }, { 0.15351d, new GammaParticle(48300.0, 0.02567) }, { 0.0301d, new GammaParticle(154200.0, 0.00804) }, { 0.07783000000000001d, new GammaParticle(207500.0, 0.00598) }, { 0.01677d, new GammaParticle(228400.0, 0.00543) }, { 0.010320000000000001d, new GammaParticle(293200.0, 0.00423) }, { 0.07654d, new GammaParticle(382400.0, 0.00324) }, { 0.00989d, new GammaParticle(430500.0, 0.00288) }, { 0.00774d, new GammaParticle(435500.0, 0.00285) }, { 0.00301d, new GammaParticle(611600.0, 0.00203) }, { 0.01075d, new GammaParticle(749000.0, 0.00166) }, { 0.00301d, new GammaParticle(839600.0, 0.00148) }, { 0.03311d, new GammaParticle(993800.0, 0.00125) }, { 0.00774d, new GammaParticle(1042000.0, 0.00119) }, { 0.00344d, new GammaParticle(1047100.0, 0.00118) }, { 0.0301d, new GammaParticle(1117000.0, 0.00111) }, { 0.02193d, new GammaParticle(1275800.0, 0.00097) }, { 0.057190000000000005d, new GammaParticle(1399000.0, 0.00089) }, { 0.10191d, new GammaParticle(2010600.0, 0.00062) }, { 0.07697d, new GammaParticle(2239000.0, 0.00055) }, { 0.43d, new GammaParticle(2441100.0, 0.00051) }, { 0.21586d, new GammaParticle(2660000.0, 0.00047) }, { 0.003140352840544d, new GammaParticle(1535.0, 0.80771) }, { 0.023074884191105885d, new GammaParticle(11879.0, 0.10437) }, { 0.044537510502038d, new GammaParticle(11925.0, 0.10397) }, { 0.010563652085830037d, new GammaParticle(13345.0, 0.09291) }, { 0.011379166026856116d, new GammaParticle(13377.0, 0.09268) }, { 0.0008155139410260789d, new GammaParticle(13469.0, 0.09205) } } },

        };
    }
}
    