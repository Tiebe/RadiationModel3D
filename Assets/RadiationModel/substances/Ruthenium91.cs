using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium91 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium91";
        public override double halfLife { get; } = 8.0d;
        public override double atomicWeight { get; } = 90.92674d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum91() }, { 1.0d, new BetaParticle(1, 6984600.0) }, { 0.0026910000000000002d, new GammaParticle(204700.0, 0.00606) }, { 0.00759d, new GammaParticle(304100.0, 0.00408) }, { 0.069d, new GammaParticle(394400.0, 0.00314) }, { 0.004968d, new GammaParticle(657600.0, 0.00189) }, { 0.005865d, new GammaParticle(669600.0, 0.00185) }, { 0.014490000000000001d, new GammaParticle(699100.0, 0.00177) }, { 0.014490000000000001d, new GammaParticle(892800.0, 0.00139) }, { 0.022080000000000002d, new GammaParticle(905300.0, 0.00137) }, { 0.00414d, new GammaParticle(944700.0, 0.00131) }, { 0.01311d, new GammaParticle(1070700.0, 0.00116) }, { 0.02553d, new GammaParticle(1096700.0, 0.00113) }, { 0.01173d, new GammaParticle(1248400.0, 0.00099) }, { 0.004209d, new GammaParticle(1371900.0, 0.0009) }, { 0.0069d, new GammaParticle(1465500.0, 0.00085) }, { 0.006555d, new GammaParticle(1997600.0, 0.00062) }, { 1.974d, new GammaParticle(511000.0, 0.00243) }, { 0.00048192921440925996d, new GammaParticle(2586.0, 0.47944) }, { 0.0022949612444587266d, new GammaParticle(18250.0, 0.06794) }, { 0.004363873824793167d, new GammaParticle(18367.0, 0.0675) }, { 0.0011598333622349802d, new GammaParticle(20695.0, 0.05991) }, { 0.001343087033468107d, new GammaParticle(20820.0, 0.05955) }, { 0.0001832536712331269d, new GammaParticle(21003.0, 0.05903) } } },

        };
    }
}
    