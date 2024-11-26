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

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cobalt55()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.077d, new GammaParticle(336700.0, 0.00368)), new(0.022000000000000002d, new GammaParticle(379600.0, 0.00327)), new(0.039d, new GammaParticle(716500.0, 0.00173)), new(0.079d, new GammaParticle(716500.0, 0.00173)), new(0.022000000000000002d, new GammaParticle(748500.0, 0.00166)), new(0.02d, new GammaParticle(771000.0, 0.00161)), new(0.022000000000000002d, new GammaParticle(985700.0, 0.00126)), new(0.017d, new GammaParticle(1005800.0, 0.00123)), new(0.018000000000000002d, new GammaParticle(1128600.0, 0.0011)), new(0.013999999999999999d, new GammaParticle(1128600.0, 0.0011)), new(0.006d, new GammaParticle(1267000.0, 0.00098)), new(0.025d, new GammaParticle(1342600.0, 0.00092)), new(0.017d, new GammaParticle(1385100.0, 0.0009)), new(0.039d, new GammaParticle(1396300.0, 0.00089)), new(0.061d, new GammaParticle(1416300.0, 0.00088)), new(0.043d, new GammaParticle(1561300.0, 0.00079)), new(0.068d, new GammaParticle(1777800.0, 0.0007)), new(0.043d, new GammaParticle(1797000.0, 0.00069)), new(0.039d, new GammaParticle(1992500.0, 0.00062)), new(0.23199999999999998d, new GammaParticle(2085600.0, 0.00059)), new(0.294d, new GammaParticle(2133900.0, 0.00058)), new(0.598d, new GammaParticle(2465300.0, 0.0005)), new(0.040999999999999995d, new GammaParticle(2514300.0, 0.00049)), new(0.055d, new GammaParticle(2586900.0, 0.00048)), new(0.031d, new GammaParticle(2610000.0, 0.00048)), new(0.009000000000000001d, new GammaParticle(2990000.0, 0.00041)), new(0.063d, new GammaParticle(3182500.0, 0.00039)), new(0.03d, new GammaParticle(3593500.0, 0.00035)), new(2.022d, new GammaParticle(511000.0, 0.00243)), new(9.588320313599999e-06d, new GammaParticle(874.0, 1.41858)), new(9.566000455483515e-05d, new GammaParticle(7461.0, 0.16618)), new(0.00018669009475963145d, new GammaParticle(7478.0, 0.1658)), new(3.890784368553349e-05d, new GammaParticle(8296.0, 0.14945)), new(3.890784368553349e-05d, new GammaParticle(8296.0, 0.14945)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    