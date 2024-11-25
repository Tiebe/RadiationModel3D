import requests
import csv
import pickle
import os

atomic_numbers = {
    0: 'Neutron',
    1: 'Hydrogen',
    2: 'Helium',
    3: 'Lithium',
    4: 'Beryllium',
    5: 'Boron',
    6: 'Carbon',
    7: 'Nitrogen',
    8: 'Oxygen',
    9: 'Fluorine',
    10: 'Neon',
    11: 'Sodium',
    12: 'Magnesium',
    13: 'Aluminum',
    14: 'Silicon',
    15: 'Phosphorus',
    16: 'Sulfur',
    17: 'Chlorine',
    18: 'Argon',
    19: 'Potassium',
    20: 'Calcium',
    21: 'Scandium',
    22: 'Titanium',
    23: 'Vanadium',
    24: 'Chromium',
    25: 'Manganese',
    26: 'Iron',
    27: 'Cobalt',
    28: 'Nickel',
    29: 'Copper',
    30: 'Zinc',
    31: 'Gallium',
    32: 'Germanium',
    33: 'Arsenic',
    34: 'Selenium',
    35: 'Bromine',
    36: 'Krypton',
    37: 'Rubidium',
    38: 'Strontium',
    39: 'Yttrium',
    40: 'Zirconium',
    41: 'Niobium',
    42: 'Molybdenum',
    43: 'Technetium',
    44: 'Ruthenium',
    45: 'Rhodium',
    46: 'Palladium',
    47: 'Silver',
    48: 'Cadmium',
    49: 'Indium',
    50: 'Tin',
    51: 'Antimony',
    52: 'Tellurium',
    53: 'Iodine',
    54: 'Xenon',
    55: 'Cesium',
    56: 'Barium',
    57: 'Lanthanum',
    58: 'Cerium',
    59: 'Praseodymium',
    60: 'Neodymium',
    61: 'Promethium',
    62: 'Samarium',
    63: 'Europium',
    64: 'Gadolinium',
    65: 'Terbium',
    66: 'Dysprosium',
    67: 'Holmium',
    68: 'Erbium',
    69: 'Thulium',
    70: 'Ytterbium',
    71: 'Lutetium',
    72: 'Hafnium',
    73: 'Tantalum',
    74: 'Tungsten',
    75: 'Rhenium',
    76: 'Osmium',
    77: 'Iridium',
    78: 'Platinum',
    79: 'Gold',
    80: 'Mercury',
    81: 'Thallium',
    82: 'Lead',
    83: 'Bismuth',
    84: 'Polonium',
    85: 'Astatine',
    86: 'Radon',
    87: 'Francium',
    88: 'Radium',
    89: 'Actinium',
    90: 'Thorium',
    91: 'Protactinium',
    92: 'Uranium',
    93: 'Neptunium',
    94: 'Plutonium',
    95: 'Americium',
    96: 'Curium',
    97: 'Berkelium',
    98: 'Californium',
    99: 'Einsteinium',
    100: 'Fermium',
    101: 'Mendelevium',
    102: 'Nobelium',
    103: 'Lawrencium',
    104: 'Rutherfordium',
    105: 'Dubnium',
    106: 'Seaborgium',
    107: 'Bohrium',
    108: 'Hassium',
    109: 'Meitnerium',
    110: 'Darmstadtium',
    111: 'Roentgenium',
    112: 'Copernicium',
    113: 'Nihonium',
    114: 'Flerovium',
    115: 'Moscovium',
    116: 'Livermorium',
    117: 'Tennessine',
    118: 'Oganesson'
}

element_symbols = {
    "H": 1,
    "He": 2,
    "Li": 3,
    "Be": 4,
    "B": 5,
    "C": 6,
    "N": 7,
    "O": 8,
    "F": 9,
    "Ne": 10,
    "Na": 11,
    "Mg": 12,
    "Al": 13,
    "Si": 14,
    "P": 15,
    "S": 16,
    "Cl": 17,
    "Ar": 18,
    "K": 19,
    "Ca": 20,
    "Sc": 21,
    "Ti": 22,
    "V": 23,
    "Cr": 24,
    "Mn": 25,
    "Fe": 26,
    "Co": 27,
    "Ni": 28,
    "Cu": 29,
    "Zn": 30,
    "Ga": 31,
    "Ge": 32,
    "As": 33,
    "Se": 34,
    "Br": 35,
    "Kr": 36,
    "Rb": 37,
    "Sr": 38,
    "Y": 39,
    "Zr": 40,
    "Nb": 41,
    "Mo": 42,
    "Tc": 43,
    "Ru": 44,
    "Rh": 45,
    "Pd": 46,
    "Ag": 47,
    "Cd": 48,
    "In": 49,
    "Sn": 50,
    "Sb": 51,
    "Te": 52,
    "I": 53,
    "Xe": 54,
    "Cs": 55,
    "Ba": 56,
    "La": 57,
    "Ce": 58,
    "Pr": 59,
    "Nd": 60,
    "Pm": 61,
    "Sm": 62,
    "Eu": 63,
    "Gd": 64,
    "Tb": 65,
    "Dy": 66,
    "Ho": 67,
    "Er": 68,
    "Tm": 69,
    "Yb": 70,
    "Lu": 71,
    "Hf": 72,
    "Ta": 73,
    "W": 74,
    "Re": 75,
    "Os": 76,
    "Ir": 77,
    "Pt": 78,
    "Au": 79,
    "Hg": 80,
    "Tl": 81,
    "Pb": 82,
    "Bi": 83,
    "Po": 84,
    "At": 85,
    "Rn": 86,
    "Fr": 87,
    "Ra": 88,
    "Ac": 89,
    "Th": 90,
    "Pa": 91,
    "U": 92,
    "Np": 93,
    "Pu": 94,
    "Am": 95,
    "Cm": 96,
    "Bk": 97,
    "Cf": 98,
    "Es": 99,
    "Fm": 100,
    "Md": 101,
    "No": 102,
    "Lr": 103,
    "Rf": 104,
    "Db": 105,
    "Sg": 106,
    "Bh": 107,
    "Hs": 108,
    "Mt": 109,
    "Ds": 110,
    "Rg": 111,
    "Cn": 112,
    "Nh": 113,
    "Fl": 114,
    "Mc": 115,
    "Lv": 116,
    "Ts": 117,
    "Og": 118
}


class Isotope:
    def __init__(self, name, halfLife, atomicWeight, massNumber, elementNumber, massKeV, simple_name):
        self.name = name
        self.halfLife = halfLife
        self.atomicWeight = atomicWeight
        self.decayProducts = []
        self.massNumber = massNumber
        self.elementNumber = elementNumber
        self.massKeV = massKeV
        self.simple_name = simple_name

    def setDecayProducts(self, products):
        self.decayProducts = products

def atomicMassToKeV(atomicMass):
    return atomicMass * 931494.103472
def keVToAtomicMass(massExcessKeV):
    return massExcessKeV / 931494.103472

def get_all_basic_isotope_info():
    with open("nubase.txt", "r") as file:
        lines = file.readlines()
        isotopes = []
        for line in lines:
            line = line.replace('\n', '')
            if line[0] == "#" or line[18:31].strip() == '':
                print("Skipping line: " + line)
                continue

            mass = int(line[0:3])
            atomicNumber = int(line[4:7])
            base_name = line[11:16].strip()
            s = line[16:17].strip()

            massText = line[18:31].replace('#', '').strip()
            if massText == '':
                print("Skipping line: " + line)
                continue
            massExcessKeV = float(massText)
            massKeV = atomicMassToKeV(mass) + massExcessKeV

            energy_string = line[42:54].replace('#', '').strip()
            if energy_string == '':
                isomer_energy = 0.0
                uncertainty = 0.0
            else:
                isomer_energy = float(energy_string)
                uncertainty = float(line[54:65].replace('#', '').strip())


            isotopes.append((mass, atomicNumber, base_name, s, isomer_energy, uncertainty, massKeV))
    return isotopes



def do_iaea_request(query: str):
    response = requests.get("https://nds.iaea.org/relnsd/v1/data?" + query)
    csv_response = csv.reader(response.text.splitlines(), delimiter=',')
    return list(csv_response)[1:]

level_cache = {}

def get_isomer_levels(isotope: str):
    if isotope in level_cache:
        return level_cache[isotope]
    else:
        levels = do_iaea_request("fields=levels&nuclides=" + isotope)
        level_cache[isotope] = levels
        return levels

gamma_emission_cache = {}

def get_gamma_emissions(isotope: str, energy: float, decay_type: str):
    if isotope in gamma_emission_cache:
        all_emissions = gamma_emission_cache[isotope]
    else:
        all_emissions = do_iaea_request(f"fields=decay_rads&nuclides={isotope}&rad_types=g")
        gamma_emission_cache[isotope] = all_emissions
    return filter(lambda x: len(x) != 0 and x[17] != '' and float(x[17]) == energy and x[26] == decay_type, all_emissions)

def find_level(levels, value, uncertainty):
    target_min = value - uncertainty
    target_max = value + uncertainty

    for level in levels:
        if len(level) == 0 or level[5] == '':
            continue
        value_i = float(level[5])
        if level[6] == '':
            uncertainty_i = 0.0
        else:
            uncertainty_i = float(level[6])
        min_i = value_i - uncertainty_i
        max_i = value_i + uncertainty_i
        if max_i >= target_min and target_max >= min_i:
            return level
    return None  # No matching value found

def get_isomer_info(isotope: str, energy: float, uncertainty: float):
    levels = get_isomer_levels(isotope)
    return find_level(levels, energy, uncertainty)

states = []

def get_ground_state_info():
    global states
    if len(states) == 0:
        states = do_iaea_request("fields=ground_states&nuclides=all")
    return states


def get_isotope_info(z: int, n: int):
    ground_states = get_ground_state_info()
    for state in ground_states:
        if len(state) != 0 and state[0] == str(z) and state[1] == str(n - z):
            return state

    return None


def get_alpha_decay_products():
    return -4, -2, [{"type": "alpha", "chance": 1.0}]


def get_beta_decay_products(decay_type: str):
    add = 1 if decay_type == 'B-' else -1

    return 0, add, [{ "type": decay_type, "chance": 1.0 }]

def get_gamma_decay_products():
    return 0, 0, []

def get_ec_decay_products():
    return 0, -1, []

def get_proton_decay_products(decay_type: str):
    amount_str = decay_type[:-1]
    if amount_str == "":
        amount = 1
    else:
        amount = int(amount_str)

    return -amount, -amount, [{ "type": "proton", "chance": 1.0 }]
def get_neutron_decay_products(decay_type: str):
    amount_str = decay_type[:-1]
    if amount_str == "":
        amount = 1
    else:
        amount = int(amount_str)

    return -amount, 0, [{ "type": "neutron", "chance": 1.0 }]

def get_decay_results(isotope: Isotope, decay_type: str, isomer_info: list):
    energy = float(isomer_info[5])
    decay_type = decay_type.replace("B-A", "B-").replace("B-N", "B-").replace("B+A", "B+").replace("B-P", "B-").replace("D", "").replace("3H", "").replace("SF", "")
    if decay_type == "":
        return []

    results = []
    initialMass = isotope.massNumber
    initialElement = isotope.elementNumber

    if decay_type == 'A': # Alpha decay
        (addMass, addElement, result) = get_alpha_decay_products()
    elif decay_type == 'B-' or decay_type == 'B+': # Beta decay
        (addMass, addElement, result) = get_beta_decay_products(decay_type)
    elif decay_type == 'EC': # Electron capture
        (addMass, addElement, result) = get_ec_decay_products()
    elif decay_type == 'IT': # Isomeric transition
        (addMass, addElement, result) = get_gamma_decay_products()
    elif decay_type == "EC+B+":
        (addMass, addElement, result) = get_ec_decay_products()
        (addMass2, addElement2, result2) = get_beta_decay_products("B+")
        addMass += addMass2
        addElement += addElement2
        result.extend(result2)
    elif decay_type == "ECP":
        (addMass, addElement, result) = get_ec_decay_products()
        (addMass2, addElement2, result2) = get_proton_decay_products("P")
        addMass += addMass2
        addElement += addElement2
        result.extend(result2)
    elif decay_type == "B+P":
        (addMass, addElement, result) = get_beta_decay_products("B+")
        (addMass2, addElement2, result2) = get_proton_decay_products("P")
        addMass += addMass2
        addElement += addElement2
        result.extend(result2)
    elif decay_type == "B+2P":
        (addMass, addElement, result) = get_beta_decay_products("B+")
        (addMass2, addElement2, result2) = get_proton_decay_products("2P")
        addMass += addMass2
        addElement += addElement2
        result.extend(result2)
    elif decay_type == "EC2P":
        (addMass, addElement, result) = get_ec_decay_products()
        (addMass2, addElement2, result2) = get_proton_decay_products("2P")
        addMass += addMass2
        addElement += addElement2
        result.extend(result2)
    elif decay_type == "ECA":
        (addMass, addElement, result) = get_ec_decay_products()
        (addMass2, addElement2, result2) = get_alpha_decay_products()
        addMass += addMass2
        addElement += addElement2
        result.extend(result2)
    elif decay_type == "B-2N":
        (addMass, addElement, result) = get_beta_decay_products("B-")
        (addMass2, addElement2, result2) = get_neutron_decay_products("2N")
        addMass += addMass2
        addElement += addElement2
        result.extend(result2)
    elif decay_type == "2B-":
        (addMass, addElement, result) = get_beta_decay_products("B-")
        (addMass2, addElement2, result2) = get_beta_decay_products("B-")
        addMass += addMass2
        addElement += addElement2
        result.extend(result2)
    elif decay_type == "2EC":
        (addMass, addElement, result) = get_ec_decay_products()
        (addMass2, addElement2, result2) = get_ec_decay_products()
        addMass += addMass2
        addElement += addElement2
        result.extend(result2)
    elif decay_type.endswith("P"):
        (addMass, addElement, result) = get_proton_decay_products(decay_type)
    elif decay_type.endswith("N"):
        (addMass, addElement, result) = get_neutron_decay_products(decay_type)
    else:
        print("Unknown decay type: " + decay_type)
        return []

    results.append({ "type": "substance", "mass": initialMass + addMass, "element": initialElement + addElement, "chance": 1.0 })
    results.extend(result)

    gamma_emissions = get_gamma_emissions(isotope.simple_name, energy, decay_type)
    for gamma_emission in gamma_emissions:
        if gamma_emission[2] == '':
            continue
        results.append({ "type": "gamma", "energy": float(gamma_emission[0]) * 1000, "chance": float(gamma_emission[2]) / 100.0 })

    return results

def get_all_isotopes() -> list[Isotope]:
    basic_isotope_info = get_all_basic_isotope_info()

    isotopes = []

    for basic_isotope in basic_isotope_info:
        mass, atomicNumber, base_name, s, isomer_energy, uncertainty, massKeV = basic_isotope
        isotope_info = get_isotope_info(atomicNumber, mass)
        if isotope_info is None:
            print(f"Could not find isotope info for {atomicNumber} {mass}")
            continue
        isomer_info = get_isomer_info(base_name, isomer_energy, uncertainty)

        if isomer_info is None:
            #print(f"Could not find isomer info for {base_name} {isomer_energy} {uncertainty}")
            isotopes.append(Isotope(atomic_numbers[atomicNumber] + str(mass) + s, 0.0, keVToAtomicMass(massKeV), mass, atomicNumber, massKeV, base_name))
            continue

        half_life = isomer_info[14]
        if half_life == '':
            half_life = 0.0
        element = atomic_numbers[atomicNumber]

        isotope = Isotope(element + str(mass) + s, float(half_life), keVToAtomicMass(massKeV), mass, atomicNumber, massKeV, base_name)

        decays = []
        for i in range(16, 24, 3):
            if isomer_info[i] == '':
                continue
            decay_type = isomer_info[i]
            if isomer_info[i + 1] == '':
                decays.append([1.0, []])
                continue
            decay_chance = float(isomer_info[i + 1]) / 100.0
            decays.append([decay_chance, get_decay_results(isotope, decay_type, isomer_info)])

        isotope.setDecayProducts(decays)
        isotopes.append(isotope)
    return isotopes

def getIsotopeFromMassElementInfo(isotopes, mass, element, info):
    name = atomic_numbers[element] + str(mass) + info
    return next((x for x in isotopes if x.name == name), None)

def getDecayProductString(isotopes, isotope, decayProduct, decayProducts):
    if decayProduct["type"] == "alpha":
        originalEnergy = isotope.massKeV
        finalEnergy = 3.7273794118*(10**6) # mass of alpha particle in keV
        for product in decayProducts:
            if product["type"] == "substance":
                newIsotope = getIsotopeFromMassElementInfo(isotopes, product["mass"], product["element"], product.get("info", ""))
                if newIsotope is not None:
                    finalEnergy += newIsotope.massKeV
                else:
                    print(f"Could not find isotope {product['mass']} {product['element']} {product.get('info', '')}")

        return f"{{ {decayProduct["chance"]}d, new AlphaParticle({round(originalEnergy - finalEnergy, 5) * 1000}) }}"
    if decayProduct["type"] == "B-" or decayProduct["type"] == "B+":
        charge = -1 if decayProduct["type"] == "B-" else 1
        originalEnergy = isotope.massKeV
        finalEnergy = 0
        for product in decayProducts:
            if product["type"] == "substance":
                newIsotope = getIsotopeFromMassElementInfo(isotopes, product["mass"], product["element"], product.get("info", ""))
                if newIsotope is not None:
                    finalEnergy += newIsotope.massKeV
                else:
                    print(f"Could not find isotope {product['mass']} {product['element']} {product.get('info', '')}")

        return f"{{ {decayProduct["chance"]}d, new BetaParticle({charge}, {round((originalEnergy - finalEnergy)/2 * 1000, 5)}) }}"
    if decayProduct["type"] == "gamma":
        energy = decayProduct["energy"]

        planckEV = 4.135667696 * (10 ** -15)
        c = 299792458.0

        wavelength = round(((planckEV * c) / energy) * 10**9, 5)
        return f"{{ {decayProduct["chance"]}d, new GammaParticle({round(energy, 5)}, {wavelength}) }}"
    if decayProduct["type"] == "proton":
        return f"{{ {decayProduct["chance"]}d, new ProtonParticle() }}"
    if decayProduct["type"] == "neutron":
        return f"{{ {decayProduct["chance"]}d, new NeutronParticle() }}"
    if decayProduct["type"] == "substance":
        name = atomic_numbers[decayProduct["element"]] + str(decayProduct["mass"])
        isotope = getIsotopeFromMassElementInfo(isotopes, decayProduct["mass"], decayProduct["element"], decayProduct.get("info", ""))
        if isotope is None:
            print(f"Could not find isotope {decayProduct['mass']} {decayProduct['element']} {decayProduct.get('info', '')}")
            return ""

        if "info" in decayProduct:
            name += decayProduct["info"]
        return f"{{ {decayProduct["chance"]}d, new {name}() }}"
    else:
        print(f"Unknown decay product: {decayProduct}")
    return ""


def generateFile(isotopes, isotope: Isotope):
    name = isotope.name
    halfLife = round(isotope.halfLife, 5)
    if halfLife == 0:
        halfLife = "double.PositiveInfinity"
    else:
        halfLife = str(halfLife) + "d"
    atomicWeight = round(isotope.atomicWeight, 5)

    decayProducts = ""
    for decayProduct in isotope.decayProducts:
        decayProducts += f"""            {{ {str(decayProduct[0])}d, new Dictionary<double, RadioactiveSubstance> {{ {', '.join(filter(lambda x: x != "", [getDecayProductString(isotopes, isotope, product, decayProduct[1]) for product in decayProduct[1]]))} }} }},
"""

    return f"""using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{{
    public class {name} : RadioactiveSubstance
    {{
        public override string name {{ get; }} = "{name}";
        public override double halfLife {{ get; }} = {str(halfLife)};
        public override double atomicWeight {{ get; }} = {str(atomicWeight)}d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts {{ get; }} = new()
        {{
{decayProducts}
        }};
    }}
}}
    """

def generateSubstancesFile(isotopes):
    with open("Substances.cs", 'w') as file:
        file.write(f"""using System;
using System.Collections.Generic;
using RadiationModel.substances;

namespace RadiationModel
{{
    // list of all radioactive substances names with their respective class
    public static class Substances
    {{
        private static readonly Dictionary<string, Type> substances = new()
        {{
            {{ "AlphaParticle", typeof(AlphaParticle) }},
            {{ "BetaParticle", typeof(BetaParticle) }},
            {{ "GammaParticle", typeof(GammaParticle) }}, 

            {',\n            '.join([f'{{ "{isotope.name}", typeof({isotope.name}) }}' for isotope in isotopes])}
        }};
        
        public static RadioactiveSubstance GetSubstanceByName(string name)
        {{
            return (RadioactiveSubstance) Activator.CreateInstance(substances[name]);
        }}
    }}

}}
""")


def write_to_cs(isotopes: list[Isotope]):
    folder = "substances"
    if not os.path.exists(folder):
        os.makedirs(folder)

    for isotope in isotopes:
        with open(f"{folder}/{isotope.name}.cs", "w") as file:
            file.write(generateFile(isotopes, isotope))



def main():
    isotopes = get_all_isotopes()
    write_to_cs(isotopes)
    generateSubstancesFile(isotopes)


if __name__ == "__main__":
    try:
        with open("level_cache.pk", 'rb+') as fi:
            level_cache = pickle.load(fi)
        with open("gamma_emission_cache.pk", 'rb+') as fi:
            gamma_emission_cache = pickle.load(fi)
        main()
    finally:
        with open("level_cache.pk", 'wb+') as fi:
            pickle.dump(level_cache, fi)
        with open("gamma_emission_cache.pk", 'wb+') as fi:
            pickle.dump(gamma_emission_cache, fi)
