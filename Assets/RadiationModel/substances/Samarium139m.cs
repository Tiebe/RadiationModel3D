using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium139m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium139m";
        public override double halfLife { get; } = 10.7d;
        public override double atomicWeight { get; } = 138.92279d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.937d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium139() }, { 0.00062d, new GammaParticle(43800.0, 0.02831) }, { 0.008100000000000001d, new GammaParticle(111600.0, 0.01111) }, { 0.25d, new GammaParticle(111900.0, 0.01108) }, { 0.37d, new GammaParticle(155300.0, 0.00798) }, { 0.37d, new GammaParticle(190100.0, 0.00652) }, { 0.032d, new GammaParticle(223500.0, 0.00555) }, { 0.37d, new GammaParticle(267300.0, 0.00464) }, { 0.149791203536d, new GammaParticle(6354.0, 0.19513) }, { 0.179734198882101d, new GammaParticle(39522.0, 0.03137) }, { 0.32531076720742264d, new GammaParticle(40117.0, 0.03091) }, { 0.10169148641532301d, new GammaParticle(45523.0, 0.02724) }, { 0.12792788991047635d, new GammaParticle(45998.0, 0.02695) }, { 0.026236403495153337d, new GammaParticle(46575.0, 0.02662) } } },
            { 0.063d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium139() }, { 1.0d, new BetaParticle(1, 5047000.0) }, { 0.0253d, new GammaParticle(188700.0, 0.00657) }, { 0.106d, new GammaParticle(511000.0, 0.00243) }, { 0.0058357498752000005d, new GammaParticle(6109.0, 0.20295) }, { 0.006707012402659656d, new GammaParticle(38171.0, 0.03248) }, { 0.01217685621397904d, new GammaParticle(38724.0, 0.03202) }, { 0.003775271426699526d, new GammaParticle(43934.0, 0.02822) }, { 0.004745516183361304d, new GammaParticle(44387.0, 0.02793) }, { 0.0009702447566617783d, new GammaParticle(44938.0, 0.02759) } } },

        };
    }
}
    