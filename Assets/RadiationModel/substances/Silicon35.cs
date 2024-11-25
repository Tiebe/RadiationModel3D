using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon35 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon35";
        public override double halfLife { get; } = 0.78d;
        public override double atomicWeight { get; } = 34.98455d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Phosphorus35() }, { 1.0d, new BetaParticle(-1, 5233900.0) }, { 0.27d, new GammaParticle(241400.0, 0.00514) }, { 0.1566d, new GammaParticle(392300.0, 0.00316) }, { 0.05049000000000001d, new GammaParticle(468900.0, 0.00264) }, { 0.0594d, new GammaParticle(633700.0, 0.00196) }, { 0.0432d, new GammaParticle(768000.0, 0.00161) }, { 0.06480000000000001d, new GammaParticle(1009900.0, 0.00123) }, { 0.032400000000000005d, new GammaParticle(1459700.0, 0.00085) }, { 0.045899999999999996d, new GammaParticle(1473400.0, 0.00084) }, { 0.0594d, new GammaParticle(1714700.0, 0.00072) }, { 0.09720000000000001d, new GammaParticle(1994800.0, 0.00062) }, { 0.3159d, new GammaParticle(2386400.0, 0.00052) }, { 0.09449999999999999d, new GammaParticle(3173500.0, 0.00039) }, { 0.1242d, new GammaParticle(3349100.0, 0.00037) }, { 0.162d, new GammaParticle(3590000.0, 0.00035) }, { 0.3267d, new GammaParticle(3859500.0, 0.00032) }, { 0.36450000000000005d, new GammaParticle(4100800.0, 0.0003) } } },
            { 0.05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Phosphorus35() }, { 1.0d, new BetaParticle(-1, 5233900.0) }, { 0.27d, new GammaParticle(241400.0, 0.00514) }, { 0.1566d, new GammaParticle(392300.0, 0.00316) }, { 0.05049000000000001d, new GammaParticle(468900.0, 0.00264) }, { 0.0594d, new GammaParticle(633700.0, 0.00196) }, { 0.0432d, new GammaParticle(768000.0, 0.00161) }, { 0.06480000000000001d, new GammaParticle(1009900.0, 0.00123) }, { 0.032400000000000005d, new GammaParticle(1459700.0, 0.00085) }, { 0.045899999999999996d, new GammaParticle(1473400.0, 0.00084) }, { 0.0594d, new GammaParticle(1714700.0, 0.00072) }, { 0.09720000000000001d, new GammaParticle(1994800.0, 0.00062) }, { 0.3159d, new GammaParticle(2386400.0, 0.00052) }, { 0.09449999999999999d, new GammaParticle(3173500.0, 0.00039) }, { 0.1242d, new GammaParticle(3349100.0, 0.00037) }, { 0.162d, new GammaParticle(3590000.0, 0.00035) }, { 0.3267d, new GammaParticle(3859500.0, 0.00032) }, { 0.36450000000000005d, new GammaParticle(4100800.0, 0.0003) } } },

        };
    }
}
    