using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium120 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium120";
        public override double halfLife { get; } = 3.08d;
        public override double atomicWeight { get; } = 119.90797d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin120() }, { 1.0d, new BetaParticle(-1, 2683850.0) }, { 0.79d, new GammaParticle(89870.0, 0.0138) }, { 0.81d, new GammaParticle(197360.0, 0.00628) }, { 0.0019d, new GammaParticle(251500.0, 0.00493) }, { 0.125d, new GammaParticle(268080.0, 0.00462) }, { 0.125d, new GammaParticle(354880.0, 0.00349) }, { 0.07d, new GammaParticle(465380.0, 0.00266) }, { 0.132d, new GammaParticle(609960.0, 0.00203) }, { 0.19699999999999998d, new GammaParticle(696750.0, 0.00178) }, { 0.01425d, new GammaParticle(704200.0, 0.00176) }, { 0.01d, new GammaParticle(808400.0, 0.00153) }, { 0.613d, new GammaParticle(964860.0, 0.00128) }, { 0.00133d, new GammaParticle(990000.0, 0.00125) }, { 0.99d, new GammaParticle(1023020.0, 0.00121) }, { 0.01d, new GammaParticle(1112700.0, 0.00111) }, { 0.084d, new GammaParticle(1162780.0, 0.00107) }, { 1.0d, new GammaParticle(1171220.0, 0.00106) }, { 0.19d, new GammaParticle(1172500.0, 0.00106) }, { 0.00912d, new GammaParticle(1185800.0, 0.00105) }, { 0.005889999999999999d, new GammaParticle(1207500.0, 0.00103) }, { 0.00228d, new GammaParticle(1250800.0, 0.00099) }, { 0.01862d, new GammaParticle(2039800.0, 0.00061) }, { 0.00418d, new GammaParticle(2098300.0, 0.00059) }, { 0.00095d, new GammaParticle(2149200.0, 0.00058) }, { 0.011399999999999999d, new GammaParticle(2390200.0, 0.00052) }, { 0.021693038639200003d, new GammaParticle(3753.0, 0.33036) }, { 0.06655361390398157d, new GammaParticle(25044.0, 0.04951) }, { 0.12456225697919064d, new GammaParticle(25271.0, 0.04906) }, { 0.03522152140085864d, new GammaParticle(28579.0, 0.04338) }, { 0.04216016111682779d, new GammaParticle(28810.0, 0.04304) }, { 0.006938639715969153d, new GammaParticle(29107.0, 0.0426) } } },

        };
    }
}
    