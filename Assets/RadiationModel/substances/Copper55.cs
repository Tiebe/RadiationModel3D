using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper55 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper55";
        public override double halfLife { get; } = 0.0559d;
        public override double atomicWeight { get; } = 54.96603d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt55() }, { 1.0d, new BetaParticle(1, 11195000.0) }, { 0.077d, new GammaParticle(336700.0, 0.00368) }, { 0.022000000000000002d, new GammaParticle(379600.0, 0.00327) }, { 0.039d, new GammaParticle(716500.0, 0.00173) }, { 0.079d, new GammaParticle(716500.0, 0.00173) }, { 0.022000000000000002d, new GammaParticle(748500.0, 0.00166) }, { 0.02d, new GammaParticle(771000.0, 0.00161) }, { 0.022000000000000002d, new GammaParticle(985700.0, 0.00126) }, { 0.017d, new GammaParticle(1005800.0, 0.00123) }, { 0.018000000000000002d, new GammaParticle(1128600.0, 0.0011) }, { 0.013999999999999999d, new GammaParticle(1128600.0, 0.0011) }, { 0.006d, new GammaParticle(1267000.0, 0.00098) }, { 0.025d, new GammaParticle(1342600.0, 0.00092) }, { 0.017d, new GammaParticle(1385100.0, 0.0009) }, { 0.039d, new GammaParticle(1396300.0, 0.00089) }, { 0.061d, new GammaParticle(1416300.0, 0.00088) }, { 0.043d, new GammaParticle(1561300.0, 0.00079) }, { 0.068d, new GammaParticle(1777800.0, 0.0007) }, { 0.043d, new GammaParticle(1797000.0, 0.00069) }, { 0.039d, new GammaParticle(1992500.0, 0.00062) }, { 0.23199999999999998d, new GammaParticle(2085600.0, 0.00059) }, { 0.294d, new GammaParticle(2133900.0, 0.00058) }, { 0.598d, new GammaParticle(2465300.0, 0.0005) }, { 0.040999999999999995d, new GammaParticle(2514300.0, 0.00049) }, { 0.055d, new GammaParticle(2586900.0, 0.00048) }, { 0.031d, new GammaParticle(2610000.0, 0.00048) }, { 0.009000000000000001d, new GammaParticle(2990000.0, 0.00041) }, { 0.063d, new GammaParticle(3182500.0, 0.00039) }, { 0.03d, new GammaParticle(3593500.0, 0.00035) }, { 2.022d, new GammaParticle(511000.0, 0.00243) }, { 9.588320313599999e-06d, new GammaParticle(874.0, 1.41858) }, { 9.566000455483515e-05d, new GammaParticle(7461.0, 0.16618) }, { 0.00018669009475963145d, new GammaParticle(7478.0, 0.1658) }, { 3.890784368553349e-05d, new GammaParticle(8296.0, 0.14945) }, { 3.890784368553349e-05d, new GammaParticle(8296.0, 0.14945) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    