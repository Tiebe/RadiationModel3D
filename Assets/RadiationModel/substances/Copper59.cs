using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper59 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper59";
        public override double halfLife { get; } = 81.5d;
        public override double atomicWeight { get; } = 58.9395d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt59() }, { 1.0d, new BetaParticle(1, 2935650.0) }, { 0.0797d, new GammaParticle(339300.0, 0.00365) }, { 0.026600000000000002d, new GammaParticle(423400.0, 0.00293) }, { 0.0587d, new GammaParticle(464900.0, 0.00267) }, { 0.0016d, new GammaParticle(538550.0, 0.0023) }, { 0.0023d, new GammaParticle(545750.0, 0.00227) }, { 0.0208d, new GammaParticle(836500.0, 0.00148) }, { 0.00035000000000000005d, new GammaParticle(850000.0, 0.00146) }, { 0.114d, new GammaParticle(878000.0, 0.00141) }, { 0.0005d, new GammaParticle(962000.0, 0.00129) }, { 0.00041d, new GammaParticle(998700.0, 0.00124) }, { 0.00379d, new GammaParticle(1188850.0, 0.00104) }, { 0.000305d, new GammaParticle(1214200.0, 0.00102) }, { 0.00035999999999999997d, new GammaParticle(1225800.0, 0.00101) }, { 0.00245d, new GammaParticle(1269650.0, 0.00098) }, { 0.1478d, new GammaParticle(1301350.0, 0.00095) }, { 0.00016d, new GammaParticle(1338000.0, 0.00093) }, { 0.01425d, new GammaParticle(1340250.0, 0.00093) }, { 0.0034000000000000002d, new GammaParticle(1395200.0, 0.00089) }, { 0.0005600000000000001d, new GammaParticle(1536900.0, 0.00081) }, { 0.00016d, new GammaParticle(1610600.0, 0.00077) }, { 0.00244d, new GammaParticle(1679700.0, 0.00074) }, { 0.01188d, new GammaParticle(1734700.0, 0.00071) }, { 0.00025d, new GammaParticle(1802600.0, 0.00069) }, { 0.00117d, new GammaParticle(1949900.0, 0.00064) }, { 0.00012d, new GammaParticle(2242900.0, 0.00055) }, { 0.00035999999999999997d, new GammaParticle(2414700.0, 0.00051) }, { 0.00013d, new GammaParticle(2682000.0, 0.00046) }, { 1.96244d, new GammaParticle(511000.0, 0.00243) }, { 0.00020256775950594963d, new GammaParticle(874.0, 1.41858) }, { 0.002020689608532043d, new GammaParticle(7461.0, 0.16618) }, { 0.00394357847098369d, new GammaParticle(7478.0, 0.1658) }, { 0.0008218761413572679d, new GammaParticle(8296.0, 0.14945) }, { 0.0008218761413572679d, new GammaParticle(8296.0, 0.14945) } } },

        };
    }
}
    