using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium225 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium225";
        public override double halfLife { get; } = 1287360.0d;
        public override double atomicWeight { get; } = 225.02361d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Actinium225() }, { 1.0d, new BetaParticle(-1, 178000.0) }, { 0.3d, new GammaParticle(40090.0, 0.03093) }, { 0.00221501221056d, new GammaParticle(10869.0, 0.11407) }, { 0.00383636123856d, new GammaParticle(12500.0, 0.09919) }, { 0.00383636123856d, new GammaParticle(12651.0, 0.098) }, { 0.049887662400000005d, new GammaParticle(13368.0, 0.09275) }, { 0.0010642889376d, new GammaParticle(14081.0, 0.08805) }, { 0.033634261990079996d, new GammaParticle(14600.0, 0.08492) }, { 0.00425161632d, new GammaParticle(15189.0, 0.08163) }, { 0.00056871935136d, new GammaParticle(15212.0, 0.0815) }, { 0.15312d, new GammaParticle(15349.0, 0.08078) }, { 0.0080069698152d, new GammaParticle(15600.0, 0.07948) }, { 0.037545748632d, new GammaParticle(15712.0, 0.07891) }, { 0.00013968545472d, new GammaParticle(15789.0, 0.07853) }, { 0.0014666972745599998d, new GammaParticle(15829.0, 0.07833) }, { 0.00400912008d, new GammaParticle(15929.0, 0.07784) }, { 0.049272636d, new GammaParticle(16580.0, 0.07478) }, { 0.011331599999999999d, new GammaParticle(17508.0, 0.07082) }, { 0.00029070855239999996d, new GammaParticle(17812.0, 0.06961) }, { 0.008647347618d, new GammaParticle(18406.0, 0.06736) }, { 0.00115808952d, new GammaParticle(18734.0, 0.06618) }, { 0.008647347618d, new GammaParticle(18812.0, 0.06591) }, { 0.001246476d, new GammaParticle(18922.0, 0.06552) }, { 0.001625996988d, new GammaParticle(18998.0, 0.06526) }, { 1.47817908e-05d, new GammaParticle(19041.0, 0.06511) }, { 0.00055751472d, new GammaParticle(19654.0, 0.06308) }, { 0.00010651704d, new GammaParticle(19825.0, 0.06254) } } },
            { 0.00026d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon221() }, { 1.0d, new AlphaParticle(6119002.09) } } },

        };
    }
}
    