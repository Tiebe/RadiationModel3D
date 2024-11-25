using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium113 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium113";
        public override double halfLife { get; } = 0.152d;
        public override double atomicWeight { get; } = 112.93257d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium113() }, { 1.0d, new BetaParticle(-1, 4529000.0) }, { 0.04d, new GammaParticle(65800.0, 0.01884) }, { 0.5d, new GammaParticle(98500.0, 0.01259) }, { 0.06d, new GammaParticle(113200.0, 0.01095) }, { 0.08d, new GammaParticle(131100.0, 0.00946) }, { 0.0d, new GammaParticle(147100.0, 0.00843) }, { 0.27d, new GammaParticle(164300.0, 0.00755) }, { 0.06d, new GammaParticle(197100.0, 0.00629) }, { 0.025d, new GammaParticle(274700.0, 0.00451) }, { 0.12d, new GammaParticle(294300.0, 0.00421) }, { 0.165d, new GammaParticle(335500.0, 0.0037) }, { 0.15d, new GammaParticle(433400.0, 0.00286) }, { 0.095d, new GammaParticle(589500.0, 0.0021) }, { 0.125d, new GammaParticle(1520100.0, 0.00082) }, { 0.005436d, new GammaParticle(2737.0, 0.45299) }, { 0.0273690099585624d, new GammaParticle(19150.0, 0.06474) }, { 0.05193360523446376d, new GammaParticle(19279.0, 0.06431) }, { 0.013956441314091093d, new GammaParticle(21736.0, 0.05704) }, { 0.01621738480697385d, new GammaParticle(21875.0, 0.05668) }, { 0.0022609434928827572d, new GammaParticle(22072.0, 0.05617) } } },
            { 0.021d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium113() }, { 1.0d, new BetaParticle(-1, 4529000.0) }, { 0.04d, new GammaParticle(65800.0, 0.01884) }, { 0.5d, new GammaParticle(98500.0, 0.01259) }, { 0.06d, new GammaParticle(113200.0, 0.01095) }, { 0.08d, new GammaParticle(131100.0, 0.00946) }, { 0.0d, new GammaParticle(147100.0, 0.00843) }, { 0.27d, new GammaParticle(164300.0, 0.00755) }, { 0.06d, new GammaParticle(197100.0, 0.00629) }, { 0.025d, new GammaParticle(274700.0, 0.00451) }, { 0.12d, new GammaParticle(294300.0, 0.00421) }, { 0.165d, new GammaParticle(335500.0, 0.0037) }, { 0.15d, new GammaParticle(433400.0, 0.00286) }, { 0.095d, new GammaParticle(589500.0, 0.0021) }, { 0.125d, new GammaParticle(1520100.0, 0.00082) }, { 0.005436d, new GammaParticle(2737.0, 0.45299) }, { 0.0273690099585624d, new GammaParticle(19150.0, 0.06474) }, { 0.05193360523446376d, new GammaParticle(19279.0, 0.06431) }, { 0.013956441314091093d, new GammaParticle(21736.0, 0.05704) }, { 0.01621738480697385d, new GammaParticle(21875.0, 0.05668) }, { 0.0022609434928827572d, new GammaParticle(22072.0, 0.05617) } } },

        };
    }
}
    